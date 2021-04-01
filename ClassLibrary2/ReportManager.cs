using ClosedXML.Excel;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ClassLibrary2
{
    public class ReportManager : IReportManager
    {
        public void ExportToExcel()
        {
           
            var data = File.ReadLines("Test.csv").Skip(1).Select(line => new Report(line)).Select(doc =>
            new
            {
                doc.RegistrationNumber,
                doc.CompanyName,
                doc.PostalCode,
                doc.City,
                doc.Country,
                doc.Street,
                doc.HouseNumber,
                doc.AdditionalAddress,
                doc.PhoneNumber,
                doc.Email,
                doc.PersonRepresentativeSalutationDesc,
                doc.PersonRepresentativeAcademicTitleDesc,
                doc.PersonRepresentativeFirstName,
                doc.PersonRepresentativeSurname,
                doc.PersonContactSalutationDesc,
                doc.PersonContactAcademicTitleDesc,
                doc.PersonContactFirstName,
                doc.PersonContactSurname,
                doc.EuropeanIdentificationNumberKey,
                doc.EuropeanIdentificationNumberTypeDesc,
                doc.NationalIdentificationNumberKey,
                doc.NationalIdentificationNumberBodyKey,
                doc.NationalIdentificationNumberTypeDesc,
                doc.NationalIdentificationNumberTypeMiscKey,
                doc.TaxpayerReferenceNumberKey,
                doc.TaxpayerReferenceNumberTypeMiscKey,
                doc.TaxpayerReferenceNumberTypeDesc
            }).AsEnumerable();

            using (var workbook = new XLWorkbook(XLEventTracking.Disabled))
            {
                var exportWorkSheet = workbook.Worksheets.Add("Data");
                var table = exportWorkSheet.Cell(1, 1).InsertTable(data);
                workbook.SaveAs("Export.xlsx");
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
