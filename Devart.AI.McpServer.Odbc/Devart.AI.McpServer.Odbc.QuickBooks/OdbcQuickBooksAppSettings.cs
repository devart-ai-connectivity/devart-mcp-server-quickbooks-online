// --------------------------------------------------------------------------
// <copyright file="OdbcQuickBooksAppSettings.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

namespace Devart.AI.McpServer.Odbc.QuickBooks
{
  internal sealed class OdbcQuickBooksAppSettings : McpAppSettings
  {
    public override string ServerName => $"Devart {Properties.ProductInfo.ProductFullName}";

    public override string SourceName => "QuickBooks Online";

    public override bool OnPremise => false;
  }
}
