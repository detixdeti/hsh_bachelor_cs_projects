
//Texture that is being drawn
uniform sampler2D tex;

//Texturepos data from vertex Shader
varying vec2 tex_pos;

void main() {

	//Position of the Pixel on the screen
	vec2 pos = gl_FragCoord.xy;

	//Size of the texture
	ivec2 size = textureSize(tex, 0);

	//Position of the Pixel in the texture
	vec2 sample_pos = tex_pos;

	//Get Pixel from Texture at point
	vec4 col = texture(tex, vec2(sample_pos.x / size.x, sample_pos.y / size.y));

	//Write color to the pixel on the screen
	gl_FragColor = vec4(col.r, col.g, col.b, col.a);
}