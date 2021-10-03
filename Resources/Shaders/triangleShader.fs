#version 330 core

in vec3 ourColor;
in vec2 ourTexCoord;

out vec4 FragColor;

uniform sampler2D ourTexture;
uniform sampler2D ourTexture1;
uniform float mixValue;
void main()
{
	FragColor = mix(texture(ourTexture, ourTexCoord), texture(ourTexture1, ourTexCoord), mixValue);
}