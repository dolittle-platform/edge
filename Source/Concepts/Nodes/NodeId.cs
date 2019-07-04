/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Dolittle.Concepts;
using Dolittle.Runtime.Events;
using System;

namespace Concepts.Nodes
{
    public class NodeId : ConceptAs<Guid>
    {
        public static readonly NodeId NotSet = Guid.Empty;
        public static implicit operator NodeId(Guid value)
        {
            return new NodeId {Value = value};
        }

        public static implicit operator EventSourceId(NodeId id)
        {
            return new EventSourceId { Value = id.Value };
        }
    }
}
