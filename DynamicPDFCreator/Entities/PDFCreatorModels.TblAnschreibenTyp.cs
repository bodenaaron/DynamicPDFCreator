﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 06.03.2020 15:35:09
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace DynamicPDFCreator
{

    /// <summary>
    /// There are no comments for DynamicPDFCreator.TblAnschreibenTyp, DynamicPDFCreator in the schema.
    /// </summary>
    public partial class TblAnschreibenTyp {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();
        
        #endregion
        /// <summary>
        /// There are no comments for TblAnschreibenTyp constructor in the schema.
        /// </summary>
        public TblAnschreibenTyp()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        public virtual short Id
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Bezeichnung in the schema.
        /// </summary>
        public virtual string Bezeichnung
        {
            get;
            set;
        }
    }

}
