using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Temere.Items.Armor
{
public class GlowingMushroomShirt : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Glowing Mushroom Shirt";
            item.width = 34;
            item.height = 22;
            item.toolTip = "Why does it glow?";
            item.toolTip2 = "+10% magic damage";
            item.value = 130;
            item.rare = 1;
            item.defense = 3;
        }
        public override void UpdateEquip(Player player)
        {
            player.magicDamage += 0.1f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GlowingMushroom, 15);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
