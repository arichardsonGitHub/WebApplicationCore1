﻿using System.Collections.Generic;

public class Album
{
    public int ID { get; set; }
    public int UserID { get; set; }
    public string Title { get; set; }

    public List<Photo> Photos { get; set; }
}