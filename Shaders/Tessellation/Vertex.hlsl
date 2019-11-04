﻿
//////////////
// TYPEDEFS //
//////////////
struct VertexInputType
{
    float3 position : POSITION;
    //float4 color : COLOR;
};

struct HullInputType
{
    float3 position : POSITION;
    //float4 color : COLOR;
};


////////////////////////////////////////////////////////////////////////////////
// Vertex Shader
////////////////////////////////////////////////////////////////////////////////
HullInputType VS(VertexInputType input)
{
    HullInputType output;

    // Pass the vertex position into the hull shader.
    output.position = input.position;
    
    // Pass the input color into the hull shader.
    //output.color = input.color;
    
    return output;
}
