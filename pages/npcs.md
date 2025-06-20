---
layout:       page
title:        NPC's for DnD 5e
title_simple: NPC's
sub_title:    Cool Tabletop Stuff
description:  A collection of magic items for your DND 5e or tabletop game
permalink:    /npcs/
---

Here is a collection of NPC's I've created for your enjoyment in your DND 5e, Pathfinder, or tabletop game:


## Latest NPC

{% assign postIndex = 0 %}

<div class="post-list">
{% for post in site.categories.npc %}
    <div class="post-list-post">
        {% if postIndex == 1 %}
            <h2>All NPC's</h2>
        {% endif %}
        {% if post.image %}
            {% include list-image.html side="left" image_base_path=post.image_base_path src=post.image url=post.url image_suffix=post.image_suffix alt=post.title size=120 %}
        {% else %}
            <div class="image-left" style="height: 120px"></div>
        {% endif %}

        <div class="post-text">
            <a href="{{ post.url }}">{{ post.title_simple }}</a>

            <div>
                <em>{{ post.date | date: "%B %-d, %Y" }}</em>
            </div>

            {% if postIndex == 0 %}
            <div>
                <em>{{ post.excerpt }}</em>
                <a class="link-right" href="{{ post.url }}">Read more</a>
            </div>
            {% endif %}

            <div class="tags">
            {% for tag in post.tags %}
                <span class="tag">{{ tag }}</span>
            {% endfor %}
            </div>
        </div>
    </div>
    <div style="clear: both;"></div>
    {% assign postIndex = postIndex | plus:1 %}
{% endfor %}
</div>