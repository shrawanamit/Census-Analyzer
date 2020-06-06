using System;
using System.Runtime.Serialization;

namespace CensusAnalyser
{
    [Serializable]
    internal class CensusAnalyzerException : Exception
    {
       

        public enum ExceptionType
        {
            EMPTY_FILE, FILE_NOT_FOUND,
            WRONG_DELIMETER, INVALID_CENSUS_DATA
        }
        public ExceptionType EType;

        public CensusAnalyzerException(ExceptionType EType, string message) : base(message)
        {
            this.EType = EType;
        }
        

       
    }
}