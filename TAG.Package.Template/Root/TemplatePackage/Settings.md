Title: Template Package Settings
Description: Template configuration page.
Master: /Master.md
Cache-Control: max-age=0, no-cache, no-store
UserVariable: User
Privilege: Admin.TemplatePackage
Login: /Login.md

{{
if exists(Posted) then
(
	SetSetting("TAG.TemplatePackage.Config1",Posted.Config1);
	SetSetting("TAG.TemplatePackage.Config2",num(Posted.Config2));
);
"";
}}

=====================

<form action="Settings.md" method="post">
	<fieldset>
		<legend>Template Settings</legend>

		<p>
		<label for="Config1">Config1:</label>  
		<input type="text" id="Config1" name="Config1" value='{{GetSetting("TAG.TemplatePackage.Config1","")}}' autofocus required title="Config1"/>
		</p>

		<p>
		<label for="Config2">Config2:</label>  
		<input type="number" id="Config2" name="Config2" value='{{GetSetting("TAG.TemplatePackage.Config2","")}}' autofocus required title="Config2"/>
		</p>

		<button type="submit" class="posButton">Apply</button>
	</fieldset>
</form>