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
using monovitez.DAL.HelperClasses;
using monovitez.DAL.FactoryClasses;
using monovitez.DAL.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace monovitez.DAL.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'VehicleMake'.<br/><br/></summary>
	[Serializable]
	public partial class VehicleMakeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private EntityCollection<VehicleModelEntity> _vehicleModels;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static VehicleMakeEntityStaticMetaData _staticMetaData = new VehicleMakeEntityStaticMetaData();
		private static VehicleMakeRelations _relationsFactory = new VehicleMakeRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name VehicleModels</summary>
			public static readonly string VehicleModels = "VehicleModels";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class VehicleMakeEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public VehicleMakeEntityStaticMetaData()
			{
				SetEntityCoreInfo("VehicleMakeEntity", InheritanceHierarchyType.None, false, (int)monovitez.DAL.EntityType.VehicleMakeEntity, typeof(VehicleMakeEntity), typeof(VehicleMakeEntityFactory), false);
				AddNavigatorMetaData<VehicleMakeEntity, EntityCollection<VehicleModelEntity>>("VehicleModels", a => a._vehicleModels, (a, b) => a._vehicleModels = b, a => a.VehicleModels, () => new VehicleMakeRelations().VehicleModelEntityUsingMakeId, typeof(VehicleModelEntity), (int)monovitez.DAL.EntityType.VehicleModelEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static VehicleMakeEntity()
		{
		}

		/// <summary> CTor</summary>
		public VehicleMakeEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public VehicleMakeEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this VehicleMakeEntity</param>
		public VehicleMakeEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for VehicleMake which data should be fetched into this VehicleMake object</param>
		public VehicleMakeEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for VehicleMake which data should be fetched into this VehicleMake object</param>
		/// <param name="validator">The custom validator object for this VehicleMakeEntity</param>
		public VehicleMakeEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected VehicleMakeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'VehicleModel' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoVehicleModels() { return CreateRelationInfoForNavigator("VehicleModels"); }
		
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
		/// <param name="validator">The validator object for this VehicleMakeEntity</param>
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
		public static VehicleMakeRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'VehicleModel' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathVehicleModels { get { return _staticMetaData.GetPrefetchPathElement("VehicleModels", CommonEntityBase.CreateEntityCollection<VehicleModelEntity>()); } }

		/// <summary>The Abrv property of the Entity VehicleMake<br/><br/></summary>
		/// <remarks>Mapped on  table field: "VehicleMake"."Abrv".<br/>Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 10485760.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Abrv
		{
			get { return (System.String)GetValue((int)VehicleMakeFieldIndex.Abrv, true); }
			set	{ SetValue((int)VehicleMakeFieldIndex.Abrv, value); }
		}

		/// <summary>The Id property of the Entity VehicleMake<br/><br/></summary>
		/// <remarks>Mapped on  table field: "VehicleMake"."Id".<br/>Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)VehicleMakeFieldIndex.Id, true); }
			set { SetValue((int)VehicleMakeFieldIndex.Id, value); }		}

		/// <summary>The Name property of the Entity VehicleMake<br/><br/></summary>
		/// <remarks>Mapped on  table field: "VehicleMake"."Name".<br/>Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 10485760.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)VehicleMakeFieldIndex.Name, true); }
			set	{ SetValue((int)VehicleMakeFieldIndex.Name, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'VehicleModelEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(VehicleModelEntity))]
		public virtual EntityCollection<VehicleModelEntity> VehicleModels { get { return GetOrCreateEntityCollection<VehicleModelEntity, VehicleModelEntityFactory>("VehicleMake", true, false, ref _vehicleModels); } }
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace monovitez.DAL
{
	public enum VehicleMakeFieldIndex
	{
		///<summary>Abrv. </summary>
		Abrv,
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace monovitez.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: VehicleMake. </summary>
	public partial class VehicleMakeRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between VehicleMakeEntity and VehicleModelEntity over the 1:n relation they have, using the relation between the fields: VehicleMake.Id - VehicleModel.MakeId</summary>
		public virtual IEntityRelation VehicleModelEntityUsingMakeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "VehicleModels", true, new[] { VehicleMakeFields.Id, VehicleModelFields.MakeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticVehicleMakeRelations
	{
		internal static readonly IEntityRelation VehicleModelEntityUsingMakeIdStatic = new VehicleMakeRelations().VehicleModelEntityUsingMakeId;

		/// <summary>CTor</summary>
		static StaticVehicleMakeRelations() { }
	}
}
