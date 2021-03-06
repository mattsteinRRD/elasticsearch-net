﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	public class TopMetricsAggregate : MetricAggregateBase
	{
		public IReadOnlyCollection<TopMetric> Top { get; internal set; } = EmptyReadOnly<TopMetric>.Collection;
	}

	public class TopMetric
	{
		/// <summary>
		/// The sort values used in sorting the hit relative to other hits
		/// </summary>
		[DataMember(Name = "sort")]
		public IReadOnlyCollection<object> Sort { get; internal set; }

		/// <summary>
		/// The metrics.
		/// </summary>
		[DataMember(Name = "metrics")]
		public IReadOnlyDictionary<string, object> Metrics { get; internal set; }
	}
}
