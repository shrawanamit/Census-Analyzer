using System;
using System.Runtime.Serialization;

namespace CensusAnalyser
{
    [Serializable]
    public class CensusAnalyzerException : Exception
    {
       

        public enum ExceptionType
        {
            EMPTY_FILE, WRONG_CSV_FILE_PATH,
            WRONG_DELIMETER, INVALID_CENSUS_DATA
        }
        public ExceptionType EType;

        public CensusAnalyzerException(ExceptionType EType, string message) : base(message)
        {
            this.EType = EType;
        }
        

       
    }
}