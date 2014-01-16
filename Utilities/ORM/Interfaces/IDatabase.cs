﻿/*
Copyright (c) 2014 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

#region Usings

using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Utilities.DataTypes;
using Utilities.DataTypes.Patterns.BaseClasses;
using Utilities.ORM.Manager.QueryProvider.Interfaces;
using Utilities.ORM.Manager.Schema.Interfaces;

#endregion Usings

namespace Utilities.ORM.Interfaces
{
    /// <summary>
    /// Database configuration interface
    /// </summary>
    public interface IDatabase
    {
        #region Properties

        /// <summary>
        /// Determines if audit tables are generated
        /// </summary>
        bool Audit { get; }

        /// <summary>
        /// Name associated with the database
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Order that this database should be in (if only one database is being used, it is ignored)
        /// </summary>
        int Order { get; }

        /// <summary>
        /// Should this database be used to read data?
        /// </summary>
        bool Readable { get; }

        /// <summary>
        /// Should the structure of the database be updated?
        /// </summary>
        bool Update { get; }

        /// <summary>
        /// Should this database be used to write data?
        /// </summary>
        bool Writable { get; }

        #endregion Properties
    }
}