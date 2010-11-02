using SquishIt.Framework.JavaScript.Minifiers;

namespace SquishIt.Framework.JavaScript
{
    public interface IJavaScriptBundleBuilder
    {
        IJavaScriptBundleBuilder Add(string path);
        IJavaScriptBundleBuilder AddRemote(string localPath, string remotePath);
        IJavaScriptBundleBuilder WithMinifier(JavaScriptMinifiers javaScriptMinifier);
        IJavaScriptBundleBuilder RenderOnlyIfOutputFileMissing();
        string Render(string renderTo);
        string RenderInLine();
        string RenderInLineEscaped();
        void AsNamed(string name, string renderTo);
        IJavaScriptBundleBuilder ForceDebug();
        IJavaScriptBundleBuilder ForceRelease();
    }
}