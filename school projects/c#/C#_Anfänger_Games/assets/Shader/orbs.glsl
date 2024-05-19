
precision highp float;


uniform float time;
uniform vec2 resolution;

void main(void) {

	vec2 p = (gl_FragCoord.xy * 2.0 - resolution) / min(resolution.x, resolution.y);
	vec3 destColor = vec3(0.0, 0.2, 1.0);
	float f = 0.0;
	for (float i = 0.0; i < 256.0; i += 4.0) {
		float s = sin(time*6.0 + i * 0.31415926) * 0.8;
		float c = cos(time*4.0 + i * 0.31415926)*0.8;
		f += 0.00001 / abs(length(p + vec2(c, s)) - i / 500000.)*(pow(i, 2.0) / 64.0);
	}

	gl_FragColor = vec4(vec3(destColor*f), 1.0);
}