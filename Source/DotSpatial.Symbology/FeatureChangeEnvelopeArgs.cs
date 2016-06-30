// ********************************************************************************************************
// Product Name: DotSpatial.Symbology.dll
// Description:  Contains the business logic for symbology layers and symbol categories.
// ********************************************************************************************************
// The contents of this file are subject to the MIT License (MIT)
// you may not use this file except in compliance with the License. You may obtain a copy of the License at
// http://dotspatial.codeplex.com/license
//
// Software distributed under the License is distributed on an "AS IS" basis, WITHOUT WARRANTY OF
// ANY KIND, either expressed or implied. See the License for the specific language governing rights and
// limitations under the License.
//
// The Original Code is from MapWindow.dll version 6.0
//
// The Initial Developer of this Original Code is Ted Dunsford. Created 8/29/2008 11:15:25 AM
//
// Contributor(s): (Open source contributors should list themselves and their modifications here).
//
// ********************************************************************************************************

using System.Collections.Generic;
using GeoAPI.Geometries;

namespace DotSpatial.Symbology
{
    ///<summary>
    ///Represents the argument for events that need to report changed features and the corresponding envelope.
    ///</summary>
    public class FeatureChangeEnvelopeArgs : FeatureChangeArgs
    {
        #region Constructors

        /// <summary>
        /// Creates a new instance of FeatureChangeEnvelopeArgs
        /// </summary>
        /// <param name="inChangedFeatures">Features that were changed.</param>
        /// <param name="inEnvelope">Geographic envelope for the most recent selection event.</param>
        public FeatureChangeEnvelopeArgs(List<int> inChangedFeatures, Envelope inEnvelope)
            : base(inChangedFeatures)
        {
            Envelope = inEnvelope;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the geographic envelope for the most recent selection event.
        /// </summary>
        public Envelope Envelope { get; protected set; }

        #endregion
    }
}