using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Temere.Items.Armor {
public class GlowingMushroomHelmet : ModItem
{

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }
        public override void SetDefaults()
        {
            item.name = "Glowing Mushroom Helmet";
            item.width = 22;
            item.height = 24;
            item.toolTip = "Why does it glow?";
            item.value = 120;
            item.rare = 1;
            item.defense = 2;
    }

    public override bool IsArmorSet(Item head, Item body, Item legs)
    {
        return body.type == mod.ItemType("GlowingMushroomShirt") && legs.type == mod.ItemType("GlowingMushroomPants");
    }


        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+40 Max mana";
            player.statManaMax2 += 40;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GlowingMushroom, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
    }   
}
}
