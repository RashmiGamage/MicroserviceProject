using System;
using Play.Common;

namespace Play.Inventory.Services.Entities
{
    public partial class InventoryItem : IEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid CatalogItemId { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset AcquiredDate { get; set; }
    }
}