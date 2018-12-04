// Python Tools for Visual Studio
// Copyright(c) Microsoft Corporation
// All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the License); you may not use
// this file except in compliance with the License. You may obtain a copy of the
// License at http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED ON AN  *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS
// OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY
// IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABILITY OR NON-INFRINGEMENT.
//
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.

#if DEV16_OR_LATER
using Microsoft.WebTools.Languages.Html.Editor.ContainedLanguage.Common;
using Microsoft.WebTools.Languages.Html.Editor.ContainedLanguage.Generators;
using Microsoft.WebTools.Languages.Html.Editor.ContentType;
using Microsoft.WebTools.Languages.Html.Editor.Tree;
#else
using Microsoft.Html.Editor.ContainedLanguage.Common;
using Microsoft.Html.Editor.ContainedLanguage.Generators;
using Microsoft.Html.Editor.ContentType;
using Microsoft.Html.Editor.Tree;
#endif

namespace Microsoft.PythonTools.Django.TemplateParsing {
    internal class TemplateBufferGenerator : ArtifactBasedBufferGenerator {
        public TemplateBufferGenerator(HtmlEditorTree editorTree, LanguageBlockCollection languageBlocks)
            : base(editorTree, languageBlocks, ContentTypeManager.GetContentType(TemplateTagContentType.ContentTypeName)) {
        }
    }
}
