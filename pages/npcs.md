---
layout:       page
title:        NPCs for DnD 5e
sub_title:    Cool Tabletop Stuff
description:  A collection of magic items for your DND 5e or tabletop game
permalink:    /npcs/
---

Here is a collection of NPC's I've created for your enjoyment in your DND 5e, Pathfinder, or tabletop game:

<div class="post-list">
{% for post in site.categories.npc %}
    <div class="post-list-post">
        {% if post.image %}
            {% include list-image.html side="left" image_base_path=post.image_base_path src=post.image url=post.url alt=post.title size=120 %}
        {% else %}
            <div class="image-left" style="height: 120px"></div>
        {% endif %}

        <a href="{{ post.url }}">{{ post.title_simple }}</a>

        <div>
            <em>{{ post.date | date: "%B %-d, %Y" }}</em>
        </div>

        <div class="tags">
        {% for tag in post.tags %}
            <span class="tag">{{ tag }}</span>
        {% endfor %}
        </div>
    </div>
    <div style="clear: both;"></div>
{% endfor %}
</div>