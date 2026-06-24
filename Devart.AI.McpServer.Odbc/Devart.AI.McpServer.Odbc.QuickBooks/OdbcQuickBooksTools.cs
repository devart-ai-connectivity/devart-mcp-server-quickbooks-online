// --------------------------------------------------------------------------
// <copyright file="OdbcQuickBooksTools.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

using System.Collections.Generic;
using ModelContextProtocol.Server;
using Devart.AI.McpServer.Odbc.QuickBooks.Tools;

namespace Devart.AI.McpServer.Odbc.QuickBooks
{
  internal static class OdbcQuickBooksTools
  {
    public static List<McpServerTool> CreateTools(McpConfiguration configuration)
      => OdbcTools.CreateBuilder(configuration)
        .Add(new OdbcQuickBooksPrimaryKeysTool(configuration))
        .Add(new OdbcQuickBooksForeignKeysTool(configuration))
        .Build();
  }
}
