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
    /// There are no comments for DynamicPDFCreator.TblWesiTeam, DynamicPDFCreator in the schema.
    /// </summary>
    public partial class WesiTeam {
    
        #region Extensibility Method Definitions
        
        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();
        
        #endregion
        /// <summary>
        /// There are no comments for TblWesiTeam constructor in the schema.
        /// </summary>
        public WesiTeam()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        public virtual short id
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Firma in the schema.
        /// </summary>
        public virtual string firma
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Stadt in the schema.
        /// </summary>
        public virtual string stadt
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for PLZ in the schema.
        /// </summary>
        public virtual string plz
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Strasse in the schema.
        /// </summary>
        public virtual string strasse
        {
            get;
            set;
        }
    
        /// <summary>
        /// There are no comments for Bereich in the schema.
        /// </summary>
        public virtual string bereich
        {
            get;
            set;
        }
        public virtual string email
        {
            get;
            set;
        }
        public virtual string niederlassung
        {
            get;
            set;
        }
        /* public virtual ISet<PDF> pdfs
         {
             get;
             set;
         }*/
    }

}