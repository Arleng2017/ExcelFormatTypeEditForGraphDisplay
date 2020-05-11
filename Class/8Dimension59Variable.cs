using ExcelFormatTypeEditForGraphDisplay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelFormatTypeEditForGraphDisplay
{
    public class _8Dimension59Variable
    {

        /// <summary>
        /// รวม 59 ตัวแปร และ 8มิติ
        /// </summary>
        public static void ManageFileDataIn8DimensionAnd59VariableFile()
        {
            var filepath = @"C:\Users\Ar'leng Chalermchai\Documents\Programming\C#\ExcelFormatTypeEditForGraphDisplay\Import\ลุ่มน้ำ.csv";
            var data = filepath.ReadData();
            SubData(data).WriterCRVFile("river8-59");
        }

        static List<_8Dimension59VariableAdressConcatExportModel> SubData(IEnumerable<string> data)
        {
            var rawDataList = new List<_8Dimension59VariableAdressConcatExportModel>();
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
                    var _59VariableDatalist = Get59VariablesDataList(headerList, dataList);
                    var _8DimensionDataList = Get8DimensionDataList(headerList, dataList);
                    rawDataList.AddRange(InputdataToFormat(_59VariableDatalist, _8DimensionDataList, dataList));
                }
            }
            return rawDataList;
        }

        static List<_8Dimension59VariableAdressConcatExportModel> InputdataToFormat(List<DataList> _59VariableDatalist, List<DataList> _8DimensionDataList, List<string> dataList)
        {
            var data = new List<_8Dimension59VariableAdressConcatExportModel>();
            for (int i = 0; i < _59VariableDatalist.Count; i++)
            {
                var dimensionHeader = "";
                var dimenstionData = "";
                if (i < 8) { dimensionHeader = _8DimensionDataList.ElementAt(0).Header; dimenstionData = _8DimensionDataList.ElementAt(0).Data; }
                else if (i < 15) { dimensionHeader = _8DimensionDataList.ElementAt(1).Header; dimenstionData = _8DimensionDataList.ElementAt(1).Data; }
                else if (i < 24) { dimensionHeader = _8DimensionDataList.ElementAt(2).Header; dimenstionData = _8DimensionDataList.ElementAt(2).Data; }
                else if (i < 25) { dimensionHeader = _8DimensionDataList.ElementAt(3).Header; dimenstionData = _8DimensionDataList.ElementAt(3).Data; }
                else if (i < 33) { dimensionHeader = _8DimensionDataList.ElementAt(4).Header; dimenstionData = _8DimensionDataList.ElementAt(4).Data; }
                else if (i < 45) { dimensionHeader = _8DimensionDataList.ElementAt(5).Header; dimenstionData = _8DimensionDataList.ElementAt(5).Data; }
                else if (i < 48) { dimensionHeader = _8DimensionDataList.ElementAt(6).Header; dimenstionData = _8DimensionDataList.ElementAt(6).Data; }
                else { dimensionHeader = _8DimensionDataList.ElementAt(7).Header; dimenstionData = _8DimensionDataList.ElementAt(7).Data; }
                data.Add(new _8Dimension59VariableAdressConcatExportModel
                {
                    Address = $"{dataList.ElementAt(1)},{dataList.ElementAt(0)}",
                    _8DimensionHeader = dimensionHeader,
                    _8DimensionValue = dimenstionData,
                    _59VariableHeader = _59VariableDatalist.ElementAt(i).Header,
                    _59VariableValue = _59VariableDatalist.ElementAt(i).Data,
                }) ;
            }
            return data;
        }

        static List<DataList> Get8DimensionDataList(List<string> headerList, List<string> dataList)
        {
            var rawData = new List<DataList>();
            for (var i = 0; i < headerList.Count(); i++)
            {
                rawData.Add(
                    new DataList
                    {
                        Header = headerList.ElementAt(i),
                        Data = dataList.ElementAt(i)
                    });
            }
            var data = rawData.Skip(63).SkipLast(0).ToList();
           
            return data;
        }

        static List<DataList> Get59VariablesDataList(List<string> headerList, List<string> dataList)
        {
            var rawData = new List<DataList>();
            for (var i = 0; i < headerList.Count(); i++)
            {
                rawData.Add(
                    new DataList
                    {
                        Header = headerList.ElementAt(i),
                        Data = dataList.ElementAt(i)
                    });
            }
            var x = rawData.Skip(2).SkipLast(11).ToList();
            return rawData.Skip(2).SkipLast(11).ToList();
        }


    }
}


