using System;

namespace ConsoleApp1
{
    public class Report
    {
        public string RegistrationNumber { get; set; }
        public string CompanyName { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string AdditionalAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PersonRepresentativeSalutationDesc { get; set; }
        public string PersonRepresentativeAcademicTitleDesc { get; set; }
        public string PersonRepresentativeFirstName { get; set; }
        public string PersonRepresentativeSurname { get; set; }
       
        public string PersonContactSalutationDesc { get; set; }
        public string PersonContactAcademicTitleDesc { get; set; }
        public string PersonContactFirstName { get; set; }
        public string PersonContactSurname { get; set; }
        public string EuropeanIdentificationNumberKey { get; set; }
        public string EuropeanIdentificationNumberTypeDesc { get; set; }
        public string NationalIdentificationNumberKey { get; set; }
        public string NationalIdentificationNumberBodyKey { get; set; }
        public string NationalIdentificationNumberTypeDesc { get; set; }
        public string NationalIdentificationNumberTypeMiscKey { get; set; }
        public string TaxpayerReferenceNumberKey { get; set; }
        public string TaxpayerReferenceNumberTypeDesc { get; set; }
        public string TaxpayerReferenceNumberTypeMiscKey { get; set; }


        public Report(string line)
        {
            var split = line.Split(',');
            RegistrationNumber = split[0];
            CompanyName = split[1];
            PostalCode = split[2];
            City = split[3];
            Country = split[4];
            Street = split[5];
            HouseNumber = split[6];
            AdditionalAddress = split[7];
            PhoneNumber = split[8];
            Email = split[9];
            PersonRepresentativeSalutationDesc = split[10];
            PersonRepresentativeAcademicTitleDesc = split[11];
            PersonRepresentativeFirstName = split[12];
            PersonRepresentativeSurname = split[13];
            PersonContactSalutationDesc = split[14];
            PersonContactAcademicTitleDesc = split[15];
            PersonContactFirstName = split[16];
            PersonContactSurname = split[17];
            EuropeanIdentificationNumberKey = split[18];
            EuropeanIdentificationNumberTypeDesc = split[19];
            NationalIdentificationNumberKey = split[20];
            NationalIdentificationNumberBodyKey = split[21];
            NationalIdentificationNumberTypeDesc = split[22];
            NationalIdentificationNumberTypeMiscKey = split[23];
            TaxpayerReferenceNumberKey = split[24];
            TaxpayerReferenceNumberTypeDesc = split[25];
            TaxpayerReferenceNumberTypeMiscKey = split[26];
        }
    }
}
