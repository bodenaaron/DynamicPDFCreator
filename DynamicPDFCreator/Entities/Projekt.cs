﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 06.03.2020 16:57:22
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


    public partial class Projekt
    {

        #region Extensibility Method Definitions

        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        #endregion

        public Projekt()
        {
            OnCreated();
        }
        public virtual int id
        {
            get;
            set;
        }

        public virtual string projektbezeichnung
        {
            get;
            set;
        }
        public virtual string bemerkungProjekt
        {
            get;
            set;
        }

        public virtual ISet<Ansprechpartner> ansprechpartner
        {
            get;
            set;
        }
        public virtual ISet<Auftrag> auftraege
        {
            get;
            set;
        }
    }

}
