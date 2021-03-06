// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.VisualStudio.Text;

namespace Microsoft.NodejsTools.Jade
{
    internal sealed class JadeOutliningTagger : OutliningTagger
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
        public JadeOutliningTagger(ITextBuffer textBuffer)
            : base(textBuffer, new IndentBasedOutlineRegionBuilder(textBuffer))
        {
            ServiceManager.AddService<JadeOutliningTagger>(this, textBuffer);
        }
    }
}
