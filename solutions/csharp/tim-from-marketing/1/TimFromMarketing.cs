static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string upperDepartment = department?.ToUpper() ?? "OWNER";
        
        if (id == null)
        {
            return $"{name} - {upperDepartment}";            
        } else {
            return $"[{id}] - {name} - {upperDepartment}";
        }
    }
}
