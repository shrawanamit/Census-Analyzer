using NUnit.Framework;
using CensusAnalyser;
using System.Data;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        public static string CENSUS_CSV_FILE_PATH = @"G:\vs\CensusAnalyser\NUnitTestProject1\IndiaStateCensusData.csv";
        public static string WRONG_CSV_FILE_PATH = @"IndiaStateCensusData.csv";

        //cheaing no of records
        [Test]
        public void GivenCensusCSVFile_ShouldReturn_CorrectNumberOfRecords()
        {
            DataTable csvData = CensusAnalyserManager.LoadCensusData(CENSUS_CSV_FILE_PATH);
            Assert.AreEqual(29, csvData.Rows.Count);
        }

    }
}