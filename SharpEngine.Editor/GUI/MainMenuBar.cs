using ImGuiNET;

namespace SharpEngine.Editor.GUI;

public class MainMenuBar : GuiObject
{
    public override void Render()
    {
        if (ImGui.BeginMainMenuBar())
        {
            if (ImGui.BeginMenu("Project"))
            {
                ImGui.MenuItem("Testing");
                ImGui.EndMenu();
            }
            ImGui.EndMainMenuBar();
        }
    }
}
