/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeApplicationVersions operation.
    /// Retrieve a list of application versions stored in your AWS Elastic Beanstalk storage
    /// bucket.
    /// </summary>
    public partial class DescribeApplicationVersionsRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private int? _maxRecords;
        private string _nextToken;
        private List<string> _versionLabels = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeApplicationVersionsRequest() { }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to only include
        /// ones that are associated with the specified application.
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// Specify a maximum number of application versions to paginate in the request.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specify a next token to retrieve the next page in a paginated request.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property VersionLabels. 
        /// <para>
        /// If specified, restricts the returned descriptions to only include ones that have the
        /// specified version labels.
        /// </para>
        /// </summary>
        public List<string> VersionLabels
        {
            get { return this._versionLabels; }
            set { this._versionLabels = value; }
        }

        // Check to see if VersionLabels property is set
        internal bool IsSetVersionLabels()
        {
            return this._versionLabels != null && this._versionLabels.Count > 0; 
        }

    }
}