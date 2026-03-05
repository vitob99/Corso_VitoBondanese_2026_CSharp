class RaccoltaBadge
{
    private static List<Badge> raccolta = new List<Badge>();

    public static List<Badge> BadgeList
    {
        get { return raccolta; }
    }

    private RaccoltaBadge(){}
    
    public static void AggiungiBadge(Badge nuovoBadge)
    {
        if (nuovoBadge != null && !raccolta.Contains(nuovoBadge))
        {
            raccolta.Add(nuovoBadge);
        }
        else
        {
            throw new Exception();
        }
    }

    public static bool RimuoviBadge(string codice)
    {
        Badge badge_da_rimuovere = CercaBadge(codice)!;
        if(CercaBadge(codice) != null)
        {
            raccolta.Remove(badge_da_rimuovere);
            return true;
        }
        return false;
    }

    public static Badge? CercaBadge(string codice)
    {
        foreach(Badge b in raccolta)
        {
            if(b.Codice == codice)
            {
                return b;
            }
        }
        return null;
    }
}