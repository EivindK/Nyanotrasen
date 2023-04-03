using Robust.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Shared.Botany
{
    public sealed class SharedSeedAnalyzer
    {
    }

    [NetSerializable, Serializable]
    public enum SeedAnalyzerUIKey : byte
    {
        Key
    }
}
