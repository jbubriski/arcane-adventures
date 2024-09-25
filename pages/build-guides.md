---
layout:       page
title:        Character Builds for DnD
sub_title:    Cool Tabletop Stuff
description:  A collection of character builds for your DnD 5e or other tabletop game
permalink:    /build-guides/
---

Here is a collection of character builds I've created for your enjoyment in your DND 5e, Pathfinder, or other tabletop game:


## Latest Build Guide

{% assign postIndex = 0 %}

<div class="post-list">
{% for post in site.categories.build-guides %}
    <div class="post-list-post">
        {% if postIndex == 1 %}
            <h2>All Magic Items</h2>
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