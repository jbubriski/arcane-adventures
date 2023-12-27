---
layout:     monster
title:      "Trash Dragon - NPC for DnD"
title_simple:      "Trash Dragon"
date:       2023-12-26 10:00:00 -0400
categories: monster
tags:       dnd dnd-5e npc tier-1 tier-2 tier-3 tier-4 legendary
image_base_path: /assets/images/trash-dragon/
image:      trash-dragon-01
images:
    - src: trash-dragon-01
      alt: Trash Dragon
    - src: trash-dragon-02
      alt: Alternate image of Trash Dragon
imagesExtra:
    - src: trash-dragon-extra-01
      alt: Extra image for Trash Dragon
    - src: trash-dragon-extra-02
      alt: Extra image for Trash Dragon
    - src: trash-dragon-extra-03
      alt: Extra image for Trash Dragon
    - src: trash-dragon-extra-04
      alt: Extra image for Trash Dragon
ac: 18 (natural armor)
hp: 224
hp_roll: 16d12 + 120
speed: 40 ft., climb 30ft.
---

<div class="stat-block">
    {% assign image = page.images[0] %}
    {% include post-image.html side="right" src=image.src alt=image.alt size=320 %}

    <h2 class="monster-name">Adult Trash Dragon</h2>
    <p><em>Huge Dragon, Chaotic Neutral</em></p>

    <hr />

    {% include monsters/core-stats.html %}

    <hr />

    {% include monsters/stats.html str=20 dex=10 con=26 wis=16 int=14 cha=20 %}

    <hr />

    <div><strong>Saving Throws</strong> DEX {% include tools/d20-roll.html type="Dexterity Saving Throw" roll="+6" %}, CON {% include tools/d20-roll.html type="Constitution Saving Throw" roll="+10" %}, WIS {% include tools/d20-roll.html type="Wisdom Saving Throw" roll="+7" %}, CHA {% include tools/d20-roll.html type="Charisma Saving Throw" roll="+8" %}</div>
    <div><strong>Skills</strong> Deception {% include tools/d20-roll.html type="Deception Skill Check" roll="+1" %}, Perception {% include tools/d20-roll.html type="Perception Skill Check" roll="+13" %}</div>
    <div><strong>Damage Immunities</strong> Acid</div>
    <div><strong>Senses</strong> Blindsight 60 ft., Darkvision 120 ft., Passive Perception 23</div>
    <div><strong>Languages</strong> Common, Undercommon, Draconic</div>
    <div><strong>Challenge 12</strong> (11,500 XP)</div>
    <div><strong>Proficiency Bonus</strong> +5</div>

    <hr />

    <div><strong>Legendary Resistance (3/Day)</strong> If the dragon fails a saving throw, it can choose to succeed instead.</div>


    <h2 id="actions">Actions</h2>

    <p><strong>Multiattack.</strong> It then makes three attacks: one bite and two punches.</p>

    <p><strong>Bite.</strong> Melee Weapon Attack: {% include tools/dice-roll.html type="Melee Weapon Attack" roll="1d20 + 8" text="+8" attack="true" %} to hit, reach 10 ft., one target. Hit: 24 ({% include tools/dice-roll.html type="Melee Weapon Attack" roll="5d6 + 6" %}) piercing damage.</p>

    <p><strong>Punch.</strong> Melee Weapon Attack: {% include tools/dice-roll.html type="Melee Weapon Attack" roll="1d20 + 10" text="+10" attack=true %} to hit, reach 5 ft., one target. Hit: 12 ({% include tools/dice-roll.html type="Melee Weapon Attack" roll="2d6 + 4" %}) bludgeoning damage.</p>

    <p><strong>Breath Weapons (Recharge 5–6).</strong> The dragon uses one of the following breath weapons.</p>

    <p><strong>Trash Breath.</strong> The dragon exhales trash in a 30-foot cone. Each creature in that area must make a DC 18 Dexterity saving throw, taking 54 ({% include tools/dice-roll.html type="Trash Breath Attack" roll="16d6" %}) bludgeoning damage on a failed save, or half as much damage on a successful one.</p>

    <p><strong>Burp Bubble.</strong> The dragon spews a giant bubble filled with noxious fumes, aimed at a creature within 30 ft. The bubble bursts creating a 15 foot radius cloud of noxious fumes centered on the creature. Each creature in the cloud must make a DC 15 Constitution saving throw, taking 42 ({% include tools/dice-roll.html type="Burp Bubble Attack" roll="12d6" %}) poison damage on a failed save, or half as much damage on a successful one. A creature that ends its turn within the cloud has to repeat the save or suffer the damage (again). The cloud lasts for 1 hour unless dispersed by a strong wind.</p>


    <h2 id="legendary_actions">Legendary Actions</h2>

    <p>The dragon can take 3 legendary actions, choosing from the options below. Only one legendary action option can be used at a time and only at the end of another creature's turn. The dragon regains spent legendary actions at the start of its turn.</p>

    <p><strong>Guzzle.</strong> The dragon rakes its mouth across the ground, consuming any items within 5 feet of it. If there are enough items or trash around it, its breath weapon attack is recharged.</p>

    <p><strong>Dumpster Dive.</strong> If inside its layer, the dragon can dive into the trash hoard. While under the trash hoard there is a low rumble as the dragon tunnels around, but its location isn't visibly obvious and the dragon has complete cover. After 2 adventurers have taken their turns, the dragon will resurface within 30 ft. of the place it went under. When surfacing, each creature within 5 feet of the dragon must make a DC 15 Dexterity saving throw, taking 24 ({% include tools/dice-roll.html type="Bludgeoning damage" roll="6d6 + 6" %}) bludgeoning damage on a failed save, or half as much damage on a successful one.</p>

    <div class="dm-note">While the dragon can't be targeted while under the trash hoard, adventurers can ready their actions to attack when the dragon resurfaces, as long as they're not affected by the resurfacing.</div>

    <p><strong>Improvised Large Trash Slam.</strong> The dragon grabs one of its large prized possessions (for example, a small boat) and attacks an area on the ground within 10 feet. Each creature within 5 feet of the target must succeed on a DC 18 Dexterity saving throw or take 20 ({% include tools/dice-roll.html type="Bludgeoning damage" roll="3d6 + 6" %}) bludgeoning damage and be knocked back 5 feet from the target.</p>
</div>


{% assign image = page.images[1] %}
{% include post-image.html side="right" src=image.src alt=image.alt size=320 %}

## Whatever

Dwelling deep under the sewers of Hemadal, Trash Dragons rest atop the piles of discarded waste rather than piles of traditional wealth. They find value in the mundane garbage discarded indiscriminately, and sometimes, accidentally, by mortals. While the value of a Trash Dragon's hoard may pale in comparison to that of a typical dragon, they're often a source of arcane, cryptic, and long-forgotten magical sundries.

In adulthood they generally prefer solitude, but younger dragons live in a perpetual commune until big enough to amass their own disgusting hoard.

## Additional Images

{% include additional-images-dall-e.html %}

{% include additional-images.html %}
