﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 13.03.2020 11:48:23
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
    /// There are no comments for DynamicPDFCreator.TblBearbeiter, DynamicPDFCreator in the schema.
    /// </summary>
    public partial class TblBearbeiter {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();
        
        #endregion
        /// <summary>
        /// There are no comments for TblBearbeiter constructor in the schema.
        /// </summary>
        public TblBearbeiter()
        {
            this.CreateDate = DateTime.Now;
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for IdBearbeiter in the schema.
        /// </summary>
        public virtual string IdBearbeiter
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for SSMATimeStamp in the schema.
        /// </summary>
        public virtual byte[] SSMATimeStamp
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Passwort in the schema.
        /// </summary>
        public virtual string Passwort
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Email in the schema.
        /// </summary>
        public virtual string Email
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Telefon in the schema.
        /// </summary>
        public virtual string Telefon
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for CreateDate in the schema.
        /// </summary>
        public virtual System.DateTime? CreateDate
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for UpdateDate in the schema.
        /// </summary>
        public virtual System.DateTime? UpdateDate
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for SollStunden in the schema.
        /// </summary>
        public virtual float? SollStunden
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for BearbeiterName in the schema.
        /// </summary>
        public virtual string BearbeiterName
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for BearbeiterVorname in the schema.
        /// </summary>
        public virtual string BearbeiterVorname
        {
            get;
            set;
        }
    }

}
