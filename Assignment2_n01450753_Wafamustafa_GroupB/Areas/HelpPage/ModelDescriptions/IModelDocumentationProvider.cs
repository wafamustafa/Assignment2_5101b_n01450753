using System;
using System.Reflection;

namespace Assignment2_n01450753_Wafamustafa_GroupB.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}