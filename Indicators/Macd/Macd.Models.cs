﻿using System;

namespace Skender.Stock.Indicators
{
    [Serializable]
    public class MacdResult : ResultBase
    {
        public decimal? Macd { get; set; }
        public decimal? Signal { get; set; }
        public decimal? Histogram { get; set; }
        public bool? IsBullish { get; set; }
        public bool? IsDiverging { get; set; }
    }
}
