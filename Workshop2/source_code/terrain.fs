#version 130

// Output color
out vec4 fragcolor;

// Variables from vertex to fragment shader
in vec3 _normal; //normal vector
in vec4 _position; //position vector

void main()
{
	//simplified lighting model
    vec4 basecolor = vec4(0.3, 0.8, 0.2, 1.0);
    fragcolor = _normal.z*basecolor;
}
