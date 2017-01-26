using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Tenere.Items
{
    public class VineSwordwrap : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Vine Swordwrap";
            // item.width
            // item.height
            item.maxStack = 1;
            item.rare = 1;
            item.value = 460;
            item.accessory = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Vine, 2);
            recipe.AddIngredient(ItemID.JungleSpores, 4);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(20, 60);
        }

        public override void UpdateAccessory(Player player)
        {
            player.meleeDamage += 0.04f;
            player.meleeSpeed += 0.03f;
        }
    }
}
