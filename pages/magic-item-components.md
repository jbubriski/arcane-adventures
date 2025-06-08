---
layout:       page
title:        Magic Item Components for DnD
title_simple: Magic Item Components
sub_title:    Cool Tabletop Stuff
description:  A collection of magic item componenets for your DnD 5e or tabletop game
permalink:    /magic-item-components/
---

Here is a collection of magic item components I've created for your enjoyment in your DND 5e, Pathfinder, or tabletop game:


## Latest Magic Item Component

{% assign postIndex = 0 %}

<div class="post-list">
{% for post in site.categories.magic-item-component %}
    <div class="post-list-post">
        {% if postIndex == 1 %}
            <h2>All Magic Item Components</h2>
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