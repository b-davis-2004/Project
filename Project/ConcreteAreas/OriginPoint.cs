using System;

namespace Project;

public class OriginPoint : AreaBase
{
    public override string Name => "Origin Point";
    public override string Description => "You awake in a clearing. The air is charged with something that tastes quite like magic." +
        "This is the starting point of your adventure.";
    public override int X => 0;
    public override int Y => 0;

}

//Origin point area - starting area for the game 
// no conflicts, just game introduction