#version 100

precision mediump float;

varying vec2 fragTexCoord;

uniform sampler2D texture0;
uniform vec4 fragTintColor;

// NOTE: Add here your custom variables

void main()
{
    vec4 color = texture2D(texture0, fragTexCoord);

    color += texture2D(texture0, fragTexCoord + 0.001);
    color += texture2D(texture0, fragTexCoord + 0.003);
    color += texture2D(texture0, fragTexCoord + 0.005);
    color += texture2D(texture0, fragTexCoord + 0.007);
    color += texture2D(texture0, fragTexCoord + 0.009);
    color += texture2D(texture0, fragTexCoord + 0.011);

    color += texture2D(texture0, fragTexCoord - 0.001);
    color += texture2D(texture0, fragTexCoord - 0.003);
    color += texture2D(texture0, fragTexCoord - 0.005);
    color += texture2D(texture0, fragTexCoord - 0.007);
    color += texture2D(texture0, fragTexCoord - 0.009);
    color += texture2D(texture0, fragTexCoord - 0.011);

    color.rgb = vec3((color.r + color.g + color.b)/3.0);
    color = color/9.5;

    gl_FragColor = color;
}			