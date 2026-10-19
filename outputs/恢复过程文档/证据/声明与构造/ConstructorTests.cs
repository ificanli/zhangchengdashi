using System;
using System.Reflection;
using BrainFailProductions.PolyFew.UnityMeshSimplifier;
using UnityEngine;
using UnityEngine.Rendering;

int checks=0, failures=0;
void Check(string label, bool value) {checks++;if(!value){failures++;Console.WriteLine("FAIL "+label);}}
object Field(LODLevel value,string name)=>typeof(LODLevel).GetField(name,BindingFlags.Instance|BindingFlags.NonPublic).GetValue(value);
var verts=new Vector3[2];var normals=new Vector3[3];var tangents=new Vector3[4];
var frame=new BlendShapeFrame(0.75f,verts,normals,tangents);
Check("frame name is empty",frame.shapeName=="");Check("frame offset -1",frame.vertexOffset==-1);
Check("frame weight",frame.frameWeight==0.75f);Check("frame references",ReferenceEquals(frame.deltaVertices,verts)&&ReferenceEquals(frame.deltaNormals,normals)&&ReferenceEquals(frame.deltaTangents,tangents));
var named=new BlendShapeFrame("mouth",0.2f,verts,normals,tangents,17);
Check("named frame",named.shapeName=="mouth"&&named.vertexOffset==17&&named.frameWeight==0.2f);
var frames=new[]{frame,named};var shape=new BlendShape("face",frames);Check("shape references",shape.ShapeName=="face"&&ReferenceEquals(shape.Frames,frames));
var border=new BorderVertex(-3,123456);Check("border",border.index==-3&&border.hash==123456);
var scalar=new Vector3d(-12.25);Check("vector scalar",scalar.x==-12.25&&scalar.y==-12.25&&scalar.z==-12.25);
var vector=new Vector3d(1.25,-3.5,9.75);Check("vector components",vector.x==1.25&&vector.y==-3.5&&vector.z==9.75);
var fromFloat=new Vector3d(new Vector3(0.1f,-0.25f,13.5f));Check("vector float widening",fromFloat.x==(double)0.1f&&fromFloat.y==-0.25&&fromFloat.z==13.5);
foreach(float height in new[]{-2f,-0.0f,0.3f,2f,float.NaN,float.PositiveInfinity})
{
 var level=new LODLevel(height,-0.75f);float actual=(float)Field(level,"screenRelativeTransitionHeight");
 float expected=float.IsNaN(height)?float.NaN:height<0?0:height>1?1:height;
 Check("height clamp",float.IsNaN(expected)?float.IsNaN(actual):BitConverter.SingleToInt32Bits(actual)==BitConverter.SingleToInt32Bits(expected));
 Check("quality clamp",(float)Field(level,"quality")==0f);
 Check("two arg defaults",(float)Field(level,"fadeTransitionWidth")==0f&&!(bool)Field(level,"combineMeshes")&&!(bool)Field(level,"combineSubMeshes")&&Field(level,"renderers")==null);
 Check("render defaults",(SkinQuality)Field(level,"skinQuality")==SkinQuality.Auto&&(ShadowCastingMode)Field(level,"shadowCastingMode")==ShadowCastingMode.On&&(bool)Field(level,"receiveShadows"));
 Check("probe defaults",(MotionVectorGenerationMode)Field(level,"motionVectorGenerationMode")==MotionVectorGenerationMode.Camera&&(bool)Field(level,"skinnedMotionVectors")&&(LightProbeUsage)Field(level,"lightProbeUsage")==LightProbeUsage.BlendProbes&&(ReflectionProbeUsage)Field(level,"reflectionProbeUsage")==ReflectionProbeUsage.BlendProbes);
}
var renderers=new Renderer[2];var explicitLevel=new LODLevel(0.4f,-0.2f,0.7f,true,false,renderers);
Check("renderers exact reference",ReferenceEquals(Field(explicitLevel,"renderers"),renderers));
Check("unclamped fade",(float)Field(explicitLevel,"fadeTransitionWidth")==-0.2f);
Check("flags",(bool)Field(explicitLevel,"combineMeshes")&&!(bool)Field(explicitLevel,"combineSubMeshes"));
var five=new LODLevel(0.6f,0.4f,3f,false,true);Check("five args",Field(five,"renderers")==null&&(float)Field(five,"quality")==1f&&(bool)Field(five,"combineSubMeshes"));
Console.WriteLine($"checks={checks} failures={failures}");Environment.ExitCode=failures==0?0:1;
