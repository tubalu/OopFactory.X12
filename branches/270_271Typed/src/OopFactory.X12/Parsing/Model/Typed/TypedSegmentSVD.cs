﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OopFactory.X12.Parsing.Model.Typed
{
    public class TypedSegmentSVD : TypedSegment
    {
        public TypedSegmentSVD()
            : base("SVD")
        {
        }
        public TypedSegmentSVD(Segment segment) : base(segment) { }
        public string SVD01_IdentificationCode
        {
            get { return _segment.GetElement(1); }
            set { _segment.SetElement(1, value); }
        }

        public decimal? SVD02_MonetaryAmount
        {
            get { return _segment.GetDecimalElement(2); }
            set { _segment.SetElement(2, value); }
        }

        public TypedElementCompositeMedicalProcedureIdentifier SVD03_CompositeMedicalProcedure
        {
            get { return new TypedElementCompositeMedicalProcedureIdentifier(_segment, 3); }
            set { _segment.SetElement(3, value); }
        }

        public string SVD04_ProductOrServiceId
        {
            get { return _segment.GetElement(4); }
            set { _segment.SetElement(4, value); }
        }

        public decimal? SVD05_Quantiy
        {
            get { return _segment.GetDecimalElement(5); }
            set { _segment.SetElement(5, value); }
        }

        public decimal? SVD06_AssignedNumber
        {
            get { return _segment.GetDecimalElement(6); }
            set { _segment.SetElement(6, value); }
        }
    }
}
