﻿/****************************************************************************
 * GffP2TestCases.cs
 * 
 *   This file contains the Gff - Parsers and Formatters P2 test cases.
 * 
***************************************************************************/

using System;
using System.IO;

using Bio.IO.Gff;
using Bio.TestAutomation.Util;
using Bio.Util.Logging;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

#if (SILVERLIGHT == false)
    namespace Bio.TestAutomation.IO.GFF
#else
    namespace Bio.Silverlight.TestAutomation.IO.GFF
#endif
{
    /// <summary>
    /// Gff P2 parser and formatter Test case implementation.
    /// </summary>
    [TestClass]
    public class GffP2TestCases
    {

        #region Enum

        /// <summary>
        /// Additional parameters to validate different scenarios.
        /// </summary>
        enum ParserOrFormatterType
        {
            parseFileName,
            parseTextReader
        }

        enum ArgumentNullExceptions
        {
            writeWithEmptyFile,
            writeWithEmptySequence,
            FormatString,
            writeCollectionWithEmptyFile,
            writeCollectionWithEmptySequence,
        }
        #endregion Enum

        #region Global Variables

        Utility utilityObj = new Utility(@"TestUtils\GffTestsConfig.xml");

        #endregion Global Variables

        #region Constructor

        /// <summary>
        /// Static constructor to open log and make other settings needed for test
        /// </summary>
        static GffP2TestCases()
        {
            Trace.Set(Trace.SeqWarnings);
            if (!ApplicationLog.Ready)
            {
                ApplicationLog.Open("bio.automation.log");
            }
        }

        #endregion Constructor

        #region Gff Parser P2 Test cases

        /// <summary>
        /// Parse a invalid Gff file to ParseFeatures()
        /// Input : Invalid Gff File
        /// Output: Expected Exception
        /// </summary>
        [TestMethod]
        [Priority(2)]
        [TestCategory("Priority2")]
        public void InvalidateGffParserFeatureLength()
        {
            InvalidateGffParserFeatures(
                Constants.InvalidFeatureLengthNode,
                ParserOrFormatterType.parseFileName);
        }

        /// <summary>
        /// Parse a invalid Gff file to ParseFeatures()
        /// Input : Invalid Gff File
        /// Output: Expected Exception
        /// </summary>
        [TestMethod]
        [Priority(2)]
        [TestCategory("Priority2")]
        public void InvalidateGffParserFeatureStart()
        {
            InvalidateGffParserFeatures(
                Constants.InvalidateStartFeatureNode,
                ParserOrFormatterType.parseFileName);
        }

        /// <summary>
        /// Parse a invalid Gff file to ParseFeatures()
        /// Input : Invalid Gff File
        /// Output: Expected Exception
        /// </summary>
        [TestMethod]
        [Priority(2)]
        [TestCategory("Priority2")]
        public void InvalidateGffParserFeatureEnd()
        {
            InvalidateGffParserFeatures(
                Constants.InvalidateEndFeatureNode,
                ParserOrFormatterType.parseFileName);
        }

        /// <summary>
        /// Parse a invalid Gff file to ParseFeatures()
        /// Input : Invalid Gff File
        /// Output: Expected Exception
        /// </summary>
        [TestMethod]
        [Priority(2)]
        [TestCategory("Priority2")]
        public void InvalidateGffParserFeatureScore()
        {
            InvalidateGffParserFeatures(
                Constants.InvalidateScoreFeatureNode,
                ParserOrFormatterType.parseFileName);
        }

        /// <summary>
        /// Parse a invalid Gff file to ParseFeatures()
        /// Input : Invalid Gff File
        /// Output: Expected Exception
        /// </summary>
        [TestMethod]
        [Priority(2)]
        [TestCategory("Priority2")]
        public void InvalidateGffParserFeatureStrand()
        {
            InvalidateGffParserFeatures(
                Constants.InvalidateStrandFeatureNode,
                ParserOrFormatterType.parseFileName);
        }

        /// <summary>
        /// Parse a invalid Gff file to ParseFeatures()
        /// Input : Invalid Gff File
        /// Output: Expected Exception
        /// </summary>
        [TestMethod]
        [Priority(2)]
        [TestCategory("Priority2")]
        public void InvalidateGffParserFeatureFrame()
        {
            InvalidateGffParserFeatures(
                Constants.InvalidateFrameFeatureNode,
                ParserOrFormatterType.parseFileName);
        }

        /// <summary>
        /// Parse a invalid Gff file to ParseFeatures()
        /// Input : Invalid Gff File
        /// Output: Expected Exception
        /// </summary>
        [TestMethod]
        [Priority(2)]
        [TestCategory("Priority2")]
        public void InvalidateGffParserNullFeatures()
        {
            InvalidateGffParserFeatures(
                Constants.InvalidateNullFeatureNode,
                ParserOrFormatterType.parseTextReader);
        }

        /// <summary>
        /// Parse a invalid Gff file to ParseHeader()
        /// Input : Invalid Gff File
        /// Output: Expected Exception
        /// </summary>
        [TestMethod]
        [Priority(2)]
        [TestCategory("Priority2")]
        public void InvalidateGffParserHeaderVersion()
        {
            InvalidateGffParserFeatures(
                Constants.InvalidateParseHeaderVersionNode,
                ParserOrFormatterType.parseFileName);
        }

        /// <summary>
        /// Parse a invalid Gff file to ParseHeader()
        /// Input : Invalid Gff File
        /// Output: Expected Exception
        /// </summary>
        [TestMethod]
        [Priority(2)]
        [TestCategory("Priority2")]
        public void InvalidateGffParserHeaderDateFormat()
        {
            InvalidateGffParserFeatures(
                Constants.InvalidateParseHeaderDateFormateNode,
                ParserOrFormatterType.parseFileName);
        }

        /// <summary>
        /// Parse a invalid Gff file to ParseHeader()
        /// Input : Invalid Gff File
        /// Output: Expected Exception
        /// </summary>
        [TestMethod]
        [Priority(2)]
        [TestCategory("Priority2")]
        public void InvalidateGffParserHeaderFieldLen()
        {
            InvalidateGffParserFeatures(
                Constants.InvalidateParseHeaderFieldLenNode,
                ParserOrFormatterType.parseFileName);
        }

        /// <summary>
        /// Parse a invalid Gff file to ParseHeader()
        /// Input : Invalid Gff File
        /// Output: Expected Exception
        /// </summary>
        [TestMethod]
        [Priority(2)]
        [TestCategory("Priority2")]
        public void InvalidateGffParserHeaderProtein()
        {
            InvalidateGffParserFeatures(
                Constants.InvalidateParseHeaderProteinNode,
                ParserOrFormatterType.parseFileName);
        }

        /// <summary>
        /// Writes a Sequence with Null value and validates the exception thrown.
        /// Input : Sequence with null value
        /// Output: Argument Null Exception
        /// </summary>
        [TestMethod]
        [Priority(2)]
        [TestCategory("Priority2")]
        public void InvalidateWriteWithNullSequence()
        {
            InvalidateGffWriteMethod(ArgumentNullExceptions.writeWithEmptySequence);
        }

        /// <summary>
        /// Tries to Write a Sequence without providing the file name and validates the exception thrown.
        /// Input : Sequence without specifying the file to be written .
        /// Output: Argument Null Exception
        /// </summary>
        [TestMethod]
        [Priority(2)]
        [TestCategory("Priority2")]
        public void InvalidateWriteWithoutFileName()
        {
            InvalidateGffWriteMethod(ArgumentNullExceptions.writeWithEmptyFile);
        }

        /// <summary>
        /// Tries to Format a String with empty sequence and validates the exception thrown.
        /// Input : Empty sequence without specifying the file to be written .
        /// Output: Argument Null Exception
        /// </summary>
        [TestMethod]
        [Priority(2)]
        [TestCategory("Priority2")]
        public void InvalidateFormatStringWithNullSequence()
        {
            InvalidateGffWriteMethod(ArgumentNullExceptions.FormatString);
        }

        /// <summary>
        /// Writes a Sequence with Null value and validates the exception thrown.
        /// Input : Sequence with null value
        /// Output: Argument Null Exception
        /// </summary>
        [TestMethod]
        [Priority(2)]
        [TestCategory("Priority2")]
        public void InvalidateWriteWithNullSequenceInACollection()
        {
            InvalidateGffWriteMethod(ArgumentNullExceptions.writeCollectionWithEmptySequence);
        }

        /// <summary>
        /// Tries to Write a Sequence without providing the file name and validates the exception thrown.
        /// Input : Sequence without specifying the file to be written .
        /// Output: Argument Null Exception
        /// </summary>
        [TestMethod]
        [Priority(2)]
        [TestCategory("Priority2")]
        public void InvalidateWriteWithoutFileNameInACollection()
        {
            InvalidateGffWriteMethod(ArgumentNullExceptions.writeCollectionWithEmptyFile);
        }

        #endregion Gff Parser P2 Test cases

        #region Helper Method

        /// <summary>
        /// General method to invalidate Gff Parser Features.
        /// </summary>
        /// <param name="nodeName">xml node name.</param>
        /// <param name="method">Gff Parse method parameters</param>
        void InvalidateGffParserFeatures(
            string nodeName,
            ParserOrFormatterType method)
        {
            try
            {
                // Gets the expected sequence from the Xml
                string filePath = utilityObj.xmlUtil.GetTextValue(
                    nodeName,
                    Constants.FilePathNode);

                switch (method)
                {
                    case ParserOrFormatterType.parseFileName:
                        new GffParser(filePath).Parse();
                        break;
                    case ParserOrFormatterType.parseTextReader:
                        new GffParser(filePath).Parse();
                        break;
                    default:
                        break;
                }

                Assert.Fail();
            }
            catch (InvalidDataException)
            {
                ApplicationLog.WriteLine(
                    "GFF Parser P2 : All the features validated successfully.");
                Console.WriteLine(
                    "GFF Parser P2 : All the features validated successfully.");
            }
            catch (InvalidOperationException)
            {
                ApplicationLog.WriteLine(
                    "GFF Parser P2 : All the features validated successfully.");
                Console.WriteLine(
                    "GFF Parser P2 : All the features validated successfully.");
            }
            catch (FormatException)
            {
                ApplicationLog.WriteLine(
                    "GFF Parser P2 : All the features validated successfully.");
                Console.WriteLine(
                    "GFF Parser P2 : All the features validated successfully.");
            }
            catch (NotSupportedException)
            {
                ApplicationLog.WriteLine(
                    "GFF Parser P2 : All the features validated successfully.");
                Console.WriteLine(
                    "GFF Parser P2 : All the features validated successfully.");
            }
        }

        /// <summary>
        /// General method to invalidate Argument Null exceptions generated from different methods.
        /// </summary>
        /// <param name="nodeName">xml node name.</param>
        /// <param name="method">Gff Parse method parameters</param>
        void InvalidateGffWriteMethod(ArgumentNullExceptions method)            
        {
            ISequence sequence=null;
            List<ISequence> collection = new List<ISequence>();
            string sequenceData = null;
            GffFormatter gffFormatter = null;

            try
            {                
                switch (method)
                {
                    case ArgumentNullExceptions.writeWithEmptyFile:
                        sequenceData = utilityObj.xmlUtil.GetTextValue(
                        Constants.SimpleGffDnaNodeName, Constants.ExpectedSequenceNode);   
                     
                        using(gffFormatter=new GffFormatter())
                        {
                            gffFormatter.Write(new Sequence(DnaAlphabet.Instance, sequenceData));
                        }                        
                        break;
                    case ArgumentNullExceptions.writeWithEmptySequence:                        

                        using(gffFormatter=new GffFormatter())
                        {
                            gffFormatter.Write(sequence);
                        }                                                                        
                        break;
                    case ArgumentNullExceptions.FormatString:

                        using (gffFormatter = new GffFormatter())
                        {
                            gffFormatter.FormatString(sequence);
                        }                                                
                        break;
                    case ArgumentNullExceptions.writeCollectionWithEmptyFile:
                        sequenceData = utilityObj.xmlUtil.GetTextValue(
                        Constants.SimpleGffDnaNodeName, Constants.ExpectedSequenceNode);
                        collection.Add(new Sequence(DnaAlphabet.Instance, sequenceData));

                        using (gffFormatter = new GffFormatter())
                        {
                            gffFormatter.Write(collection);
                        }                                                                                        
                        break;
                    case ArgumentNullExceptions.writeCollectionWithEmptySequence:

                        using (gffFormatter = new GffFormatter())
                        {
                            gffFormatter.Write(collection);
                        }                          
                        break;
                    default:
                        break;
                }

                Assert.Fail();
            }
           
            catch (ArgumentNullException)
            {                
                ApplicationLog.WriteLine(
                    "GFF P2 : Exception is validated successfully.");
                Console.WriteLine(
                    "GFF P2 : Exception is validated successfully.");
            }
        }

        #endregion Helper Method
    }
}
