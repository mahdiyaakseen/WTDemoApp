using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SomeApp.Models
{
    /// <summary>
    /// Describes a data sources query response.
    /// </summary>
    public class DataSourcesViewModel
    {

        /// <summary>
        /// Gets or sets the available data sources returned by Data Core.
        /// </summary>
        public IEnumerable<DataCore.Client.Model.ComponentInfo> DataSources { get; set; }

    }


}