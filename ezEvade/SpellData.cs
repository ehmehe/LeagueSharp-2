﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;

namespace ezEvade
{
    public enum SpellType
    {
        Line,
        Circular,
        Cone
    }

    public class SpellData
    {            
        public string charName;
        public SpellSlot spellKey = SpellSlot.Q;
        public int dangerlevel = 1;
        public string spellName;
        public string name;
        public float range;
        public float radius;
        public float projectileSpeed = float.MaxValue;
        public string missileName = "";
        public SpellType spellType;
        public float spellDelay = 250;
        public bool rangeCap = false;
        public float angle;
        public float sideRadius;
        public int splits;
        public bool usePackets = false;
        public float extraDelay = 0;
        public float extraDistance = 0;
        public bool isThreeWay = false;
        public bool defaultOff = false;
        public bool isWall = false;
        public float extraEndTime = 0;
        public bool hasEndExplosion = false;

        public SpellData()
        {
        
        }

        public SpellData(
            string charName,
            string spellName,
            string name,
            int range,
            int radius,
            int dangerlevel,
            SpellType spellType            
            )
        {
            this.charName = charName;
            this.spellName = spellName;
            this.name = name;
            this.range = range;
            this.radius = radius;
            this.dangerlevel = dangerlevel;
            this.spellType = spellType;
        }
    }
}
