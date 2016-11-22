﻿namespace Decent.Minecraft.Client.Blocks
{
    /// <summary>
    /// <a href="http://minecraft.gamepedia.com/Cobblestone">Gamepedia link</a>.
    /// </summary>
    public class Cobblestone : Block
    {
        public Cobblestone() : base(BlockType.Cobblestone) { }
        protected Cobblestone(bool mossy) : base(BlockType.Cobblestone)
        {
            IsMossy = mossy;
        }

        protected bool IsMossy { get; }
    }

    /// <summary>
    /// <a href="http://minecraft.gamepedia.com/Moss_Stone">Gamepedia link</a>.
    /// </summary>
    public class MossyCobblestone : Cobblestone
    {
        public MossyCobblestone() : base(mossy: true) { }
    }
}
