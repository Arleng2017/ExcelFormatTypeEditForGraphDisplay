using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using CsvHelper;

using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Linq;
using ExcelFormatTypeEditForGraphDisplay.Model;

namespace ExcelFormatTypeEditForGraphDisplay
{
    public static class FileManager
    {
        //public static void ReadDataFromFile()
        //{
        //    var filepath = @"/Users/Chalermchai/Documents/Programming/c#/ExcelFormatTypeEditForGraphDisplay/Import/Region.csv";
        //    var headerList = new List<string>();
        //    var dataListOf59Variable = new List<Region>();
        //    var dataListOf8Dimension = new List<Region>();


        //    using (var streamReader = new StreamReader(filepath, Encoding.UTF8))
        //    {
        //        string line;
        //        var i = 0;
        //        var x = new List<string>();
        //        while ((line = streamReader.ReadLine()) != null)
        //        {
        //            if (i == 1)
        //            {
        //                headerList.AddRange(line.Split(","));
        //            }
        //            if (i > 1)
        //            {
        //                Console.WriteLine(line);
        //                var dataList = line.Split(",").ToList();
        //                dataListOf59Variable.AddRange(GetDataListOf59Variable(headerList, dataList));
        //                dataListOf8Dimension.AddRange(GetDataListOf8Dimension(headerList, dataList));
        //            }
        //            i++;
        //        }
        //    }


            //using (StreamReader rd = new StreamReader(filepath, Encoding.UTF8))
            //{
            //    string line = null;
            //    var readLine = rd.ReadToEnd();
            //    var rawData = readLine.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList().Skip(1);
            //    rawData.GetDataListOf8DimensionInProvince();
            //}

            //FileWriterToCRV(dataListOf59Variable, "Region-59Variables-Yellow");
            // FileWriterToCRV(dataListOf8Dimension, "Region8Dimensions-Blue");
        }

        //static List<Region> GetDataListOf8Dimension(List<string> headerList, List<string> dataList)
        //{
        //    var regionData = new List<Region>();
        //    for (int i = 217; i < 238; i++)
        //    {
        //        regionData.Add(
        //           new Region()
        //           {
        //               RegionName = dataList.ElementAt(0),
        //               HeaderName = headerList.ElementAt(i),
        //               Data = dataList.ElementAt(i)
        //           });
        //    };
        //    return regionData;
        //}


        //static List<Region> GetDataListOf59Variable(List<string> headerList, List<string> dataList)
        //{
        //    var regionData = new List<Region>();
        //    for (int i = 156; i < 215; i++)
        //    {
        //        regionData.Add(
        //           new Region()
        //           {
        //               RegionName = dataList.ElementAt(0),
        //               HeaderName = headerList.ElementAt(i),
        //               Data = dataList.ElementAt(i)
        //           });
        //    };
        //    return regionData;
        //}


        //public static IEnumerable<string> ReadData(this string filePath)
        //{
        //    IEnumerable<string> rawData;
        //    using (StreamReader rd = new StreamReader(filePath, Encoding.UTF8))
        //    {
        //        var readLine = rd.ReadToEnd();
        //        rawData = readLine.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList().Skip(1);
        //    }
        //    return rawData;
        //}

        /// <summary>
        /// Region 
        /// </summary>
        /// <param name="data"></param>
        //public static void ManageFileDataInRegionFile()
        //{
        //    var filepath = @"C:\Users\Mana PC\Documents\Programming\C#\ExcelFormatTypeEditForGraphDisplay\Import\Region.csv";
        //    var data = filepath.ReadData();
        //    var regionDataList = GetRegionDataList(data, 155, 23);
        //    regionDataList.WriterCRVFile("Region-59Variable-Purple");
        //}

        //static List<Region> GetRegionDataList(IEnumerable<string> data, int start, int end)
        //{
        //    var regionDataList = new List<Region>();
        //    var headerList = new List<string>();
        //    for (int i = 0; i < data.Count(); i++)
        //    {
        //        if (i == 0)
        //        {
        //            headerList.AddRange(data.ElementAt(0).Split(","));
        //        }
        //        if (i > 0)
        //        {
        //            var dataList = new List<string>();
        //            dataList.AddRange(data.ElementAt(i).Split(","));
        //            regionDataList.AddRange(InputDataToRegionFormat(headerList, dataList, start, end));
        //        }
        //    }
        //    return regionDataList;
        //}

        //static List<Region> InputDataToRegionFormat(List<string> headerList, List<string> dataList, int start, int end)
        //{
        //    var regionDataList = new List<Region>();
        //    for (var i = 1; i < headerList.Count(); i++)
        //    {
        //        regionDataList.Add(
        //            new Region
        //            {
        //                RegionName = dataList.ElementAt(0),
        //                HeaderName = headerList.ElementAt(i),
        //                Data = dataList.ElementAt(i)

        //            });
        //    }
        //    return regionDataList.Skip(start).SkipLast(end).ToList();

        //}


        /// <summary>
        /// Province 
        /// </summary>
        /// <param name="data"></param>
        //public static void ManageFileDataInProvinceFile()
        //{
        //    var filepath = @"C:\Users\Mana PC\Documents\Programming\C#\ExcelFormatTypeEditForGraphDisplay\Import\Province.csv";
        //    var data = filepath.ReadData();
        //    var provinceDataList = GetProviceDataList(data, 155, 23);
        //    provinceDataList.WriterCRVFile("Province-59Variable-Purple");
        //}

        //static List<Province> GetProviceDataList(IEnumerable<string> data, int start, int end)
        //{
        //    var provinceDataList = new List<Province>();
        //    var headerList = new List<string>();
        //    for (int i = 0; i < data.Count(); i++)
        //    {
        //        if (i == 0)
        //        {
        //            headerList.AddRange(data.ElementAt(0).Split(","));
        //        }
        //        if (i > 0)
        //        {
        //            var dataList = new List<string>();
        //            dataList.AddRange(data.ElementAt(i).Split(","));
        //            provinceDataList.AddRange(InputDataToProvinceFormat(headerList, dataList, start, end));
        //        }
        //    }
        //    return provinceDataList;
        //}

        //static List<Province> InputDataToProvinceFormat(List<string> headerList, List<string> dataList, int start, int end)
        //{
        //    var provinceDataList = new List<Province>();
        //    for (var i = 2; i < headerList.Count(); i++)
        //    {
        //        provinceDataList.Add(
        //            new Province
        //            {
        //                ProvinceName = dataList.ElementAt(0),
        //                RegionName = dataList.ElementAt(1),
        //                HeaderName = headerList.ElementAt(i),
        //                Data = dataList.ElementAt(i)

        //            });
        //    }
        //    return provinceDataList.Skip(start).SkipLast(end).ToList();
        //}

        /// <summary>
        /// District
        /// </summary>
        //public static void ManageFileDataInDistrictFile()
        //{
        //    var filepath = @"C:\Users\Mana PC\Documents\Programming\C#\ExcelFormatTypeEditForGraphDisplay\Import\SubProvince.csv";
        //    var data = filepath.ReadData();
        //    var provinceDataList = GetSubProviceDataList(data, 155, 23);
        //    provinceDataList.WriterCRVFile("District-59Variables-Purple");
        //}

        //static List<SubProvince> GetSubProviceDataList(IEnumerable<string> data, int start, int end)
        //{
        //    var provinceDataList = new List<SubProvince>();
        //    var headerList = new List<string>();
        //    for (int i = 0; i < data.Count(); i++)
        //    {
        //        if (i == 0)
        //        {
        //            headerList.AddRange(data.ElementAt(0).Split(","));
        //        }
        //        if (i > 0)
        //        {
        //            var dataList = new List<string>();
        //            dataList.AddRange(data.ElementAt(i).Split(","));
        //            provinceDataList.AddRange(InputDataToSubProvinceFormat(headerList, dataList, start, end));
        //        }
        //    }
        //    return provinceDataList;
        //}

        //static List<SubProvince> InputDataToSubProvinceFormat(List<string> headerList, List<string> dataList, int start, int end)
        //{
        //    var subProvinceDataList = new List<SubProvince>();
        //    for (var i = 3; i < headerList.Count(); i++)
        //    {
        //        subProvinceDataList.Add(
        //            new SubProvince
        //            {
        //                SubProvinceName = dataList.ElementAt(0),
        //                ProvinceName = dataList.ElementAt(1),
        //                RegionName = dataList.ElementAt(2),
        //                HeaderName = headerList.ElementAt(i),
        //                Data = dataList.ElementAt(i)
        //            });
        //    }
        //    return subProvinceDataList.Skip(start).SkipLast(end).ToList();
        //}



        /// <summary>
        /// Sub-District
        /// </summary>
        //public static void ManageFileDataInSubDistrictFile()
        //{
        //    var filepath = @"C:\Users\Mana PC\Documents\Programming\C#\ExcelFormatTypeEditForGraphDisplay\Import\Sub-district.csv";
        //    var data = filepath.ReadData();
        //    var subDistrictDataList = GetSubDistrictDataList(data, 155, 23);
        //    subDistrictDataList.WriterCRVFile("SubDistrict-59Variable-Purple");
        //}

        //static List<SubDistrict> GetSubDistrictDataList(IEnumerable<string> data, int start, int end)
        //{
        //    var subDistrictDataList = new List<SubDistrict>();
        //    var headerList = new List<string>();
        //    for (int i = 0; i < data.Count(); i++)
        //    {
        //        if (i == 0)
        //        {
        //            headerList.AddRange(data.ElementAt(0).Split(","));
        //        }
        //        if (i > 0)
        //        {
        //            var dataList = new List<string>();
        //            dataList.AddRange(data.ElementAt(i).Split(","));
        //            subDistrictDataList.AddRange(InputDataToSubDistrictFormat(headerList, dataList, start, end));
        //        }
        //    }
        //    return subDistrictDataList;
        //}

        //static List<SubDistrict> InputDataToSubDistrictFormat(List<string> headerList, List<string> dataList, int start, int end)
        //{
        //    var subDistrictDataList = new List<SubDistrict>();
        //    for (var i = 4; i < headerList.Count(); i++)
        //    {
        //        subDistrictDataList.Add(
        //            new SubDistrict
        //            {
        //                SubDistrictName = dataList.ElementAt(0),
        //                DistrictName = dataList.ElementAt(1),
        //                ProvinceName = dataList.ElementAt(2),
        //                RegionName = dataList.ElementAt(3),
        //                HeaderName = headerList.ElementAt(i),
        //                Data = dataList.ElementAt(i)
        //            });
        //    }
        //    return subDistrictDataList.Skip(start).SkipLast(end).ToList();
        //}

        /// <summary>
        /// concat address
        /// </summary>
        /// <param name="data"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        //public static void ManageFileDataWithConcatAddressFile()
        //{
        //    var filepath = @"C:\Users\Mana PC\Documents\Programming\C#\ExcelFormatTypeEditForGraphDisplay\Import\Sub-district.csv";
        //    var data = filepath.ReadData();
        //    var subDistrictDataList = GetConcatAddressDataList(data, 155, 23);
        //    subDistrictDataList.WriterCRVFile("59Variable-Purple");
        //}

        //static List<Address> GetConcatAddressDataList(IEnumerable<string> data, int start, int end)
        //{
        //    var subDistrictDataList = new List<Address>();
        //    var headerList = new List<string>();
        //    for (int i = 0; i < data.Count(); i++)
        //    {
        //        if (i == 0)
        //        {
        //            headerList.AddRange(data.ElementAt(0).Split(","));
        //        }
        //        if (i > 0)
        //        {
        //            var dataList = new List<string>();
        //            dataList.AddRange(data.ElementAt(i).Split(","));
        //            subDistrictDataList.AddRange(InputConcatDataFormat(headerList, dataList, start, end));
        //        }
        //    }
        //    return subDistrictDataList;
        //}

        //static List<Address> InputConcatDataFormat(List<string> headerList, List<string> dataList, int start, int end)
        //{
        //    var subDistrictDataList = new List<Address>();
        //    for (var i = 4; i < headerList.Count(); i++)
        //    {
        //        subDistrictDataList.Add(
        //            new Address
        //            {
        //                AddressOfData = $"({dataList.ElementAt(2)},{dataList.ElementAt(1)}){dataList.ElementAt(0)}",
        //                HeaderName = headerList.ElementAt(i),
        //                Data = dataList.ElementAt(i)
        //            });
        //    }
        //    return subDistrictDataList.Skip(start).SkipLast(end).ToList();
        //}







        //static void WriterCRVFile<T>(List<T> records, string filename)
        //{
        //    var filePath = $@"/Users/Chalermchai/Documents/Programming/c#/ExcelFormatTypeEditForGraphDisplay/Export/{filename}.csv";
        //    using (var writer = new StreamWriter(filePath))
        //    using (CsvWriter csv = new CsvWriter(writer))
        //    {
        //        csv.WriteRecords(records);
        //    }
        //}




        //static void FileWriterToCRV(List<Region> records, string filename)
        //{
        //    var filePath = $@"/Users/Chalermchai/Documents/Programming/c#/ExcelFormatTypeEditForGraphDisplay/Export/{filename}.csv";
        //    using (var writer = new StreamWriter(filePath))
        //    using (CsvWriter csv = new CsvWriter(writer))
        //    {
        //        csv.WriteRecords(records);
        //    }
        //}

    }
}
