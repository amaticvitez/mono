﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using monovitezEnt.HelperClasses;
using monovitezEnt.FactoryClasses;
using monovitezEnt.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace monovitezEnt.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'VehicleModel'.<br/><br/></summary>
	[Serializable]
	public partial class VehicleModelEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private VehicleMakeEntity _vehicleMake;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static VehicleModelEntityStaticMetaData _staticMetaData = new VehicleModelEntityStaticMetaData();
		private static VehicleModelRelations _relationsFactory = new VehicleModelRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name VehicleMake</summary>
			public static readonly string VehicleMake = "VehicleMake";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class VehicleModelEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public VehicleModelEntityStaticMetaData()
			{
				SetEntityCoreInfo("VehicleModelEntity", InheritanceHierarchyType.None, false, (int)monovitezEnt.EntityType.VehicleModelEntity, typeof(VehicleModelEntity), typeof(VehicleModelEntityFactory), false);
				AddNavigatorMetaData<VehicleModelEntity, VehicleMakeEntity>("VehicleMake", "VehicleModels", (a, b) => a._vehicleMake = b, a => a._vehicleMake, (a, b) => a.VehicleMake = b, monovitezEnt.RelationClasses.StaticVehicleModelRelations.VehicleMakeEntityUsingMakeIdStatic, ()=>new VehicleModelRelations().VehicleMakeEntityUsingMakeId, null, new int[] { (int)VehicleModelFieldIndex.MakeId }, null, true, (int)monovitezEnt.EntityType.VehicleMakeEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static VehicleModelEntity()
		{
		}

		/// <summary> CTor</summary>
		public VehicleModelEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public VehicleModelEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this VehicleModelEntity</param>
		public VehicleModelEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for VehicleModel which data should be fetched into this VehicleModel object</param>
		public VehicleModelEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for VehicleModel which data should be fetched into this VehicleModel object</param>
		/// <param name="validator">The custom validator object for this VehicleModelEntity</param>
		public VehicleModelEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected VehicleModelEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'VehicleMake' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoVehicleMake() { return CreateRelationInfoForNavigator("VehicleMake"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this VehicleModelEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END


			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static VehicleModelRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'VehicleMake' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathVehicleMake { get { return _staticMetaData.GetPrefetchPathElement("VehicleMake", CommonEntityBase.CreateEntityCollection<VehicleMakeEntity>()); } }

		/// <summary>The Abrv property of the Entity VehicleModel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "VehicleModel"."Abrv".<br/>Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 10485760.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Abrv
		{
			get { return (System.String)GetValue((int)VehicleModelFieldIndex.Abrv, true); }
			set	{ SetValue((int)VehicleModelFieldIndex.Abrv, value); }
		}

		/// <summary>The Id property of the Entity VehicleModel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "VehicleModel"."Id".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)VehicleModelFieldIndex.Id, true); }
			set { SetValue((int)VehicleModelFieldIndex.Id, value); }		}

		/// <summary>The MakeId property of the Entity VehicleModel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "VehicleModel"."MakeId".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> MakeId
		{
			get { return (Nullable<System.Int32>)GetValue((int)VehicleModelFieldIndex.MakeId, false); }
			set	{ SetValue((int)VehicleModelFieldIndex.MakeId, value); }
		}

		/// <summary>The Name property of the Entity VehicleModel<br/><br/></summary>
		/// <remarks>Mapped on  table field: "VehicleModel"."Name".<br/>Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 10485760.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)VehicleModelFieldIndex.Name, true); }
			set	{ SetValue((int)VehicleModelFieldIndex.Name, value); }
		}

		/// <summary>Gets / sets related entity of type 'VehicleMakeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual VehicleMakeEntity VehicleMake
		{
			get { return _vehicleMake; }
			set { SetSingleRelatedEntityNavigator(value, "VehicleMake"); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace monovitezEnt
{
	public enum VehicleModelFieldIndex
	{
		///<summary>Abrv. </summary>
		Abrv,
		///<summary>Id. </summary>
		Id,
		///<summary>MakeId. </summary>
		MakeId,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace monovitezEnt.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: VehicleModel. </summary>
	public partial class VehicleModelRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between VehicleModelEntity and VehicleMakeEntity over the m:1 relation they have, using the relation between the fields: VehicleModel.MakeId - VehicleMake.Id</summary>
		public virtual IEntityRelation VehicleMakeEntityUsingMakeId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "VehicleMake", false, new[] { VehicleMakeFields.Id, VehicleModelFields.MakeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticVehicleModelRelations
	{
		internal static readonly IEntityRelation VehicleMakeEntityUsingMakeIdStatic = new VehicleModelRelations().VehicleMakeEntityUsingMakeId;

		/// <summary>CTor</summary>
		static StaticVehicleModelRelations() { }
	}
}
