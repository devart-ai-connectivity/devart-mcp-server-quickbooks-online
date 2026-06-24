// --------------------------------------------------------------------------
// <copyright file="AdoNetQuickBooksAppSettings.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

namespace Devart.AI.McpServer.AdoNet.QuickBooks
{
  internal sealed class AdoNetQuickBooksAppSettings : McpAppSettings
  {
    public override string ServerName => $"Devart {Properties.ProductInfo.ProductFullName}";

    public override string SourceName => "QuickBooks Online";

    public override bool OnPremise => true;
  }
}
