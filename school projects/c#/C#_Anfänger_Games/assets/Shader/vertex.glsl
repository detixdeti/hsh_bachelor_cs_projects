//Position of the Pixel in the texture
varying vec2 tex_pos;

void main()
{
	//Vertex contains Position and other Information
	vec4 vertex = gl_Vertex;

	// Transforming The Vertex
	gl_Position = gl_ModelViewProjectionMatrix * vertex;

	// Passing The Texture Coordinate Of Texture Unit 0 To The Fragment Shader
	tex_pos = vec2(gl_MultiTexCoord0);
}