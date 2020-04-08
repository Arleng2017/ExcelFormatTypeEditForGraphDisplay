using ExcelFormatTypeEditForGraphDisplay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelFormatTypeEditForGraphDisplay.Class
{
    class SubDistrictFileManagerWithConcatAddress
    {
        public static void ManageFileDataWithConcatAddressFile()
        {
            var filepath = @"C:\Users\Mana PC\Documents\Programming\C#\ExcelFormatTypeEditForGraphDisplay\Import\Sub-district.csv";
            var data = filepath.ReadData();
            var subDistrictDataList = GetConcatAddressDataList(data, 155, 23);
            subDistrictDataList.WriterCRVFile("59Variable-Purple");
        }
        static List<Address> GetConcatAddressDataList(IEnumerable<string> data, int start, int end)
        {
            var subDistrictDataList = new List<Address>();
            var headerList = new List<string>();
            for (int i = 0; i < data.Count(); i++)
            {
                if (i == 0)
                {
                    headerList.AddRange(data.ElementAt(0).Split(","));
                }
                if (i > 0)
                {
                    var dataList = new List<string>();
                    dataList.AddRange(data.ElementAt(i).Split(","));
                    subDistrictDataList.AddRange(InputConcatDataFormat(headerList, dataList, start, end));
                }
            }
            return subDistrictDataList;
        }
        static List<Address> InputConcatDataFormat(List<string> headerList, List<string> dataList, int start, int end)
        {
            var subDistrictDataList = new List<Address>();
            for (var i = 4; i < headerList.Count(); i++)
            {
                subDistrictDataList.Add(
                    new Address
                    {
                        AddressOfData = $"({dataList.ElementAt(2)},{dataList.ElementAt(1)}){dataList.ElementAt(0)}",
                        HeaderName = headerList.ElementAt(i),
                        Data = dataList.ElementAt(i)
                    });
            }
            return subDistrictDataList.Skip(start).SkipLast(end).ToList();
        }



    }
}
