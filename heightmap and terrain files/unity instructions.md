# how to make terrain on unity via terrain

---

## download `heightmapV2.raw` from our google drive in [NASA App thing > heightmap files > `heightmapV2.raw`](https://drive.google.com/drive/folders/19m0dbRjIW-WezsFgpvVxBR8xJpGA-WXg?usp=sharing)

1. create a 3d project, name it as you desire

2. create a scene
- left click in the Scene Viewer > Create > Scene
- name it whatever

3. create a terrain
- left click in the Hierarchy Window > Create > Terrain

4. change the terrain size to be the same as the resolution for `heightmapV2.raw`
- edit the terrain mesh by clicking on it, then in the Inspector Window under Terrain open up Terrain Settings by clicking the 5<sup>th</sub>
- under the drop down “Mesh Resolution (On Terrain Data), change the height and width to the resolution of `heightmapV2.raw` which is **4097x4097**
- change the terrain height as you see fit; begin with 275 and work your way down or up

5. import `heightmapV2.raw` onto the terrain
- Inspector Window > Texture Resolutions (On Terrain Data) > Import Raw… > `heightmapV2.raw`
