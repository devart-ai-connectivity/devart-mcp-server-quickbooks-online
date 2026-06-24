// --------------------------------------------------------------------------
// <copyright file="Program.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

using System.Threading.Tasks;
using Devart.AI.McpServer.Odbc.QuickBooks.CommandLine;

namespace Devart.AI.McpServer.Odbc.QuickBooks
{
  internal class Program
  {
    public static Task<int> Main(string[] args) => OdbcLauncher.Create(new OdbcQuickBooksRunCommand()).RunAsync(args);
  }
}
