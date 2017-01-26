using System;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using System.Collections.Generic;

namespace Temere.Items.Armor {
public class GlowingMushroomPants : ModItem
{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }
        public override void SetDefaults()
    {
        item.name = "Glowing Mushroom Pants";
        item.width = 22;
        item.height = 18;
        item.toolTip = "Why does it glow?";
        item.toolTip2 = "5% Increased magic damage";
        item.value = 120;
        item.rare = 1;
        item.defense = 2;
    }

    public override void UpdateEquip(Player player)
    {
        player.magicDamage += 0.05f;
    }

    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.GlowingMushroom, 10);
        recipe.AddTile(TileID.WorkBenches);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}
