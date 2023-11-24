---
layout:       page
title:        Magic Items
sub_title:    Cool Tabletop Stuff
description:  A collection of magic items for your DND 5e or tabletop game
permalink:    /magic-items/
---

Here is a collection of magic items I've created for your enjoyment in your DND 5e, Pathfinder, or tabletop game:

<div class="post-list">
{% for post in site.categories.magic-item %}
    <div class="post-list-post">
        {% if post.image %}
        <a href="{{ post.url }}" class="image-left" title="{{ post.title_simple }}">
            <img src="{{ post.image }}" alt="{{ post.title_simple }}" />
        </a>
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