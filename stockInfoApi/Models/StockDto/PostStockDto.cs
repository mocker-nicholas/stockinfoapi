﻿using Newtonsoft.Json;
using stockInfoApi.Models.DboModels;
using System.ComponentModel.DataAnnotations;

namespace stockInfoApi.Models.StockDto
{
    public class PostStockDto
    {
        [Key]
        [JsonProperty("stockId")]
        public Guid StockId { get; set; } = Guid.NewGuid();

        [Required]
        [JsonProperty("accountId")]
        public Guid AccountId { get; set; }

        [Required]
        [JsonProperty("symbol")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [JsonProperty("purchasePrice")]
        public double PurchasePrice { get; set; } = 0;

        [Required]
        [JsonProperty("numShares")]
        public int NumShares { get; set; } = 0;

        [Required]
        [JsonProperty("sharePrice")]
        public double SharePrice { get; set; } = 0;
    }
}
