﻿using System;
using System.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JetEntityFrameworkProvider.Test.Model68_sbyte
{
    //[TestClass]
    public class Model68_SByte_SqlCe : Test
    {
        protected override DbConnection GetConnection()
        {
            return Helpers.GetSqlCeConnection();
        }
    }
}
